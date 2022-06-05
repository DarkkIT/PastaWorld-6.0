let mealsToCart = function () {
    document.querySelectorAll('.meal-to-cart').forEach(x => x.addEventListener("click", function (event) {
        console.log(x.data-id);
        
    }));
}

mealsToCart();
