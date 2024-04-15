

$(document).ready(function () {

    var submitClick = $('#submitClick');
    submitClick.attr('disabled', 'disabled');

    var tagData = $('#divDateTime input[type=date]');

    var text = $('textArea');

    var tagSelectCode = $('#SelectCode');

    var tagSelectDate = $('#SelectDate');

    //zaznaczenie wszystkich opcji do wyszukiwania
    $('#All').click(function (e) {
        var tag = $(this);

        
        submitClick.attr('disabled', 'disabled');
    });

    //zablokowanie dostepu przy zaladowaniu strony
    //jesli nie sa zaznaczone opcje
    if (tagSelectCode.is(':checked') || tagSelectDate.is(':checked')) {
        text.removeAttr('disabled');

        if (tagSelectDate.is(':checked'))
            tagData.removeAttr('disabled');
        else
            tagData.attr('disabled', 'disabled');

        text.removeAttr('disabled');

        submitClick.removeAttr('disabled');
    }
    else {   
        text.attr('disabled', 'disabled');
        tagData.attr('disabled', 'disabled');
    }

    //blokowanie / odbkolowanie opcji wyszukiwnaia
    //po kodzie
    tagSelectCode.click(function (e) {
        var tag = $(this);

        if (tag.is(':checked')) {
            text.removeAttr('disabled');
            submitClick.removeAttr('disabled');
        }
        else {
            text.attr('disabled', 'disabled');
            submitClick.attr('disabled', 'disabled');
        }

        if (tagSelectDate.is(':checked')) {
            tagSelectDate.prop('checked', false).removeAttr('checked');
        }
    });

    //po dacie
    tagSelectDate.click(function (e) {
        var tag = $(this);

        if (tag.is(':checked')) {
            tagData.removeAttr('disabled');
            submitClick.removeAttr('disabled');
        }
        else {
            tagData.attr('disabled', 'disabled');
            submitClick.attr('disabled', 'disabled');
        }

        if (tagSelectCode.is(':checked')) {
            tagSelectCode.prop('checked', false).removeAttr('checked');
        }
    });

})