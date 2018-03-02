app.controller("logInController",function ($scope,logInService){
    debugger
    $scope.isLogIn=false;
    $scope.message = "";
    $scope.submitted = false;
    $scope.isFormValid = false;
    debugger
    //Check is Form Valid or Not // Here f1 is our form Name
    //$scope.$watch('f1.$valid', function (newVal) {
    //    debugger
    //    $scope.IsFormValid = newVal;
    //});


    $scope.logIn = function () {
        debugger
        var getData = logInService.getUSer($scope.LoginData);
        debugger
        getData.then(function (msg) {
            debugger
            alert(msg.data);
        }, function () {
            alert('Error in adding record');
        });
        //if ($scope.isFormValid) {
        //logInService.getUSer($scope.logInData).then(function (e) {
        //    debugger
        //        if (d.data.userName != "") {
        //            debugger
        //            $scope.isLogIn = true;
        //            $scope.message="SuccessFully Login"
        //        }
        //        else {
        //            alert("Invalid Credential Details");
        //        }
        //    })
        //}
    }
})