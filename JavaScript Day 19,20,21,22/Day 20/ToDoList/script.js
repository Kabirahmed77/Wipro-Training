const form = document.getElementById("form");
const input = document.getElementById("input");
const list = document.getElementById("list");

form.addEventListener("submit", function(e) {
    e.preventDefault();

    if (input.value === "") {
        alert("Enter a task");
    } else {
        const li = document.createElement("li");
        li.innerText = input.value;
        list.appendChild(li);
        input.value = "";
    }
});