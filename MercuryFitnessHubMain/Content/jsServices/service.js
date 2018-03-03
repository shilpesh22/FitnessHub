app.service("logInService", function ($http) {
    //get All Eployee
    this.getUSer = function (LoginData) {
        debugger
        var response = $http({
            method: 'POST',
            url: 'UserLogin',
            data: JSON.stringify(LoginData),
            headers: { "Content-type": "application/json" }
        });
        return response;
    }
})