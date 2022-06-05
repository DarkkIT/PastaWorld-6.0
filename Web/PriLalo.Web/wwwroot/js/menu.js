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
            //            alert("qkata rabota")
            //            //var jsonResponse = JSON.parse(xhr.responseText)
            //            //window.location.replace(jsonResponse.redirectRoute)
            //        }
            //    }

            //}));

            let data = { id: this.id }
            debugger;
            var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
            $.ajax({
                type: "POST",
                url: "/api/MealApi",
                data: JSON.stringify(data),
                dataType: 'json',
                contentType: 'application/json',
                headers: {
                    'X-CSRF-TOKEN': antiForgeryToken
                },
                success: function (data) {

                    //console.log(data);
                    //updateResource(data);

                    ////let newUnitQuantity = Number($(`#${data.unitType}`).text().split(`${data.unitType} `).filter(Boolean)) + data.unitQuantity;
                    //$(`#${data.unitType}`).text(`${data.unitType} ${data.unitQuantity}`)
                }
            });
        })
        )
}

mealsToCart();
