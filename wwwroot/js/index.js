$(document).ready(function () {
    console.log("Bare bones start over man...how disapointing");

    var theForm = $("#theForm");
    //theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Data Request Processing");
    });

    var primarchInfo = $(".primarchInfo li");
    primarchInfo.on("click", function () {
        console.log("You have chosen " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle();
    });
});