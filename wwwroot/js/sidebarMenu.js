
$('.dropdownMenu').click(function (e) {
    var tag = $(this);

    $('.dropdownMenu').each(function () {
        var target = $(this);

        var idTarget = target.attr('id');
        var idTag = tag.attr('id');

        if (idTarget != idTag) {
            if (target.attr("aria-expanded") === "true") {
                var activeClick = idTarget;
                if (idTarget != 'lineProduction' && idTarget != 'raport' && idTarget != 'searchData') {
                    $('#' + activeClick).click();
                   // activeClick.click();
                }
            }
        }
    });
});



