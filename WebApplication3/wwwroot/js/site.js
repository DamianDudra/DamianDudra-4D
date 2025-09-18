// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function zobraz() {
	const para = document.querySelector("p");
	if (para.style.display === "none") {
		para.style.display = "block";
	} else {
		para.style.display = "none";
	}
}
let kliky = 0;

function klik() {
	kliky = kliky + 1;
	document.querySelector('.totalklik').textContent = kliky;
	if (kliky == 5) {
		let karta = document.getElementById("clickcard");
		karta.style.backgroundColor = "lightblue";
	}
}


.addEventListener("submit", (event) => {
	let znaky = document.getElementById('Textbox').value.length;
	if (znaky >= 20) {
		let karta1 = document.getElementById("Textbox");
		karta1.style.outline = "green";
        classlist.add("good/bad");
	}
})
