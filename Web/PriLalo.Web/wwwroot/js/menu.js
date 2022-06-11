let mealsToCart = function () {
    document.querySelectorAll('.meal-to-cart')
        .forEach(x => x.addEventListener("click", sentPostRequest));
}

let sentPostRequest = function (event) {
    var antiForgeryToken = document.querySelector('#antiForgeryForm input[name=__RequestVerificationToken]').value;
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/MealApi", true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.setRequestHeader('X-CSRF-TOKEN', antiForgeryToken);
    xhr.send(JSON.stringify({
        id: this.id
    }));

    xhr.onreadystatechange = function () {
        if (this.status == 200) {
            document.getElementById("lblCartCount").textContent = this.responseText;
        }
    }
};

mealsToCart();
