function pressedLoginButton() {
    console.log("deju se");
    $.ajax({
        url: '/Login/TryLogin/',
        type: 'POST',
        data: {
            userName: 'argus',
            password: 'premium'
        },
        success: function (data) { 
            console.log("jaj")
            console.log(data)
        },
        error: function (data) { 
            console.log("naj")
        }
    });

}