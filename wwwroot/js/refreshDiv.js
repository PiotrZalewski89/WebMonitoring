//global variable
var activeInput = false;
var idleInterval;

$(document).ready(function () {
    idleInterval = setInterval("reloadAction()", 80000); //30 seconds

    $('#idPlan').focus(function () {
        activeInput = true;
    })

    $('#idPlan').focusout(function () {
        activeInput = false;
    })
})

function reloadAction() {
    clearInterval(idleInterval);

    if (!activeInput) {
        $('#jsRefresh').load(window.location.href + " #jsRefresh");
    }

    idleInterval = setInterval("reloadAction()", 80000);
}