var idleInterval;

$(document).ready(function () {
    idleInterval = setInterval("reloadAction()", 80000); //30 seconds

})

function reloadAction() {

    clearInterval(idleInterval);
    var element = $('#jsRefresh');

    if (element.children().length > 0) {
        console.log(element.children().length);
        element.children().remove();
    }

    element.load(window.location.href + " #jsRefresh");

    idleInterval = setInterval("reloadAction()", 80000);
}

