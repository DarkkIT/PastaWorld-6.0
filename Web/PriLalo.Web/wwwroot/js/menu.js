let mealsToCart = function () {
    document.querySelectorAll('.meal-to-cart')
        .forEach(x => x.addEventListener("click", function (event) {

            //    var xhr = new XMLHttpRequest();
            //    xhr.open("POST", "/api/MealApi/", true);
            //    xhr.setRequestHeader('Content-Type', 'application/json');
            //    //xhr.send(JSON.stringify({
            //    //    id: this.id
            //    //}));

            //    xhr.send(this.id);

            //    xhr.onreadystatechange = function (result) {
            //        if (result) {
            //            alert(result);
            //        }

            //        if (xhr.readyState == XMLHttpRequest.DONE) {
            //            alert("qkata rabota")v
            //            //var jsonResponse = JSON.parse(xhr.responseText)
            //            //window.location.replace(jsonResponse.redirectRoute)
            //        }
            //    }
            //}));

            let data = { id: this.id }
            //$.post("/Meal", JSON.stringify(data), console.log(data))

            $.get("/MealApi", { data: data }, function (data) { console.log("success!") });


            $.ajax({
                type: "POST",
                url: "/MealApi",
                data: JSON.stringify(data),
                dataType: 'json',
                contentType: 'application/json',

                success: function (data) {
                   
                    console.log("We did it!")
                    console.log(data);

                    $("#lblCartCount").text(data);
                }

            });
        })
        )
}

mealsToCart();
