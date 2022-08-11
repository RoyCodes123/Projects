$(document).ready(function () {
    $("button").click(function (){
        $("#red").fadeToggle();
        $("#blue").fadeToggle("slow");
        $("#green").fadeToggle(3000);
    });
});