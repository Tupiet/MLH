let number = document.getElementsByClassName("number")
let operator = document.getElementsByClassName("operator")
let calculate = document.getElementById("calculate")
let clear = document.getElementById("clear")
let result = document.querySelector(".result")

//let deleteBool = false

for (i = 0; i < number.length; i++) {
    number[i].addEventListener("click", function() {
        result.innerHTML += this.innerHTML
    })
}

for (i = 0; i < operator.length; i++) {
    operator[i].addEventListener("click", function() {
        result.innerHTML += this.innerHTML
    })
}

clear.addEventListener("click", function() {
    clearNow()
})

calculate.addEventListener("click", function() {
    resultValue = eval(result.textContent)
    result.innerHTML = resultValue
    
})

function clearNow() {
    result.innerHTML = ''
}

