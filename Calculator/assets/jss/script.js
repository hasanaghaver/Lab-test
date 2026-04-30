let calc = document.querySelector(".setr1");

window.addEventListener("click", (e) => {
    if (e.target.classList.contains("num")) {
        let value = e.target.innerText;
        if (calc.innerText === "0" || calc.innerText === "Error" || calc.innerText === "Infinity") {
            calc.innerText = value;
        } else {
            calc.innerText += value;
        }
    }

    if (e.target.classList.contains("emeliyyat")) {
        let op = e.target.innerText;
        if (op === "=") {
            try {
                calc.innerText = eval(calc.innerText);
            } catch {
                calc.innerText = "Error";
            }
        } else {
            calc.innerText += op;
        }
    }

    if (e.target.classList.contains("clear")) {
        calc.innerText = "";
    }
})