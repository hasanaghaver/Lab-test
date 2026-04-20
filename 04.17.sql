create database music

use music


create table Artist(
Id int primary key identity,
Name nvarchar(100),
Nationality nvarchar(50)
)

create table Album(
Id int primary key identity,
Title nvarchar(100),
ReleaseYear int,
ArtistId int foreign key references Artist(Id)
)

create table Track(
Id int primary key identity,
Title nvarchar(100),
DurationSec int,
AlbumId int foreign key references Album(Id)
)

INSERT INTO Artist (Name, Nationality) VALUES 
('Queen', 'British'),
('Daft Punk', 'French'),
('Röya', 'Azerbaijani'),
('The Weeknd', 'Canadian'),
('Coldplay', 'British');

INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES 
('A Night at the Opera', 1975, 1),
('Discovery', 2001, 2),           
('Gəl Danış', 2008, 3),            
('After Hours', 2020, 4),         
('Parachutes', 2000, 5);        


INSERT INTO Track (Title, DurationSec, AlbumId) VALUES 
('Bohemian Rhapsody', 354, 1),
('One More Time', 320, 2),
('Gəl Danış', 245, 3),
('Blinding Lights', 200, 4),
('Yellow', 269, 5);


--Hər bir albumu artisinin adı ilə birlikdə göstərin
Select al.Title, al.ReleaseYear, ar.Name as Artist , ar.Nationality from Album as al
join Artist as ar on ArtistId = ar.Id

--Hər bir track-in adını və onun aid olduğu albumun adını göstərin
Select t.Title,t.DurationSec,al.Title ,al.ReleaseYear, ar.Name from Track as t
join Album as al on AlbumId = al.Id
join Artist as ar on al.ArtistId = ar.Id

--Hər bir track-in adını və o albumun artistinin adını göstərin
Select t.Title, ar.Name from Track as t
join Album as al on AlbumId = al.Id
join Artist as ar on al.ArtistId = ar.Id

--2000-ci ildən sonra çıxan albomlardakı track-lərin adlarını göstərin
Select Track.Title from Track
join Album on AlbumId =Album.Id
where Album.ReleaseYear>2000

--Hər bir track-in adını və onun aid olduğu albumun adını göstərin, yalnız track-lərin müddəti 240 saniyədən az olanları daxil edin.
Select Track.Title, Album.Title from Track
join Album on AlbumId =Album.Id
where Track.DurationSec<240

--ArtistAlbums view-u, hər bir artistin adını və onun albomlarının adlarını göstərin.
create view ArtistAlbums
as
select Artist.Name, Album.Title from Artist
join Album on  Album.ArtistId = Artist.Id

select * from dbo.ArtistAlbums

--AlbumTracks view-u, hər bir albumun adını və onun track-lərinin adlarını göstərin.
create view AlbumTracks
as
Select Album.Title as Album, Track.Title as Title from Album
join Track on AlbumId = Album.Id

select * from dbo.AlbumTracks

--TrackDetails view-u, hər bir track-in adını, onun aid olduğu albumun adını və o albumun artistinin adını göstərin.
create view TrackDetails
as
Select t.Title as Track, al.Title as Album, ar.Name as Artist from Track as t
join Album as al on AlbumId = al.Id
join Artist as ar on al.ArtistId = ar.Id

select * from dbo.TrackDetails


--GetArtistAlbums stored procedure-u, bir artistin adını parametr olaraq qəbul edir və o artistin albomlarının adlarını qaytarır.
create procedure GetArtistAlbums(@Name nvarchar(100))
as
select * from dbo.ArtistAlbums
where ArtistAlbums.Name = @Name

EXEC dbo.GetArtistAlbums @Name = 'Queen'

--GetAlbumTracks stored procedure-u, bir albumun adını parametr olaraq qəbul edir və o albumun track-lərinin adlarını qaytarır.
create procedure GetAlbumTracks(@AlbumName nvarchar(100))
as
select * from dbo.AlbumTracks
where AlbumTracks.Album = @AlbumName

exec dbo.GetAlbumTracks @AlbumName = 'Discovery'

--GetTrackDetails stored procedure-u, bir track-in adını parametr olaraq qəbul edir və o track-in aid olduğu albumun adını və o albumun artistinin adını qaytarır.
create procedure GetTrackDetails(@TrackName nvarchar(100))
as
select * from dbo.TrackDetails
where TrackDetails.Track = @TrackName

exec dbo.GetTrackDetails @TrackName = 'Yellow'