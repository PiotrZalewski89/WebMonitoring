

$(document).ready(function () {

    var submitClick = $('#submitClick');
    submitClick.attr('disabled', 'disabled');

    var pobierz = $('#idPobierz');
    pobierz.attr('disabled', 'disabled');

    var tagCheckbox = $('.checkboxes input[type=checkbox]');

    var tagData = $('#divDateTime input[type=date]');

    var text = $('textArea');

    var tagSelectCode = $('#SelectCode');

    var tagSelectDate = $('#SelectDate');

    //zaznaczenie wszystkich opcji do wyszukiwania
    $('#All').click(function (e) {
        var tag = $(this);

        tagCheckbox.each(function () {

            var target = $(this);

            if (tag.is(':checked')) {
                if (target.is(':checked') && target != tag) {
                    target.prop('checked', false).removeAttr('checked');
                }

                target.prop('checked', true).attr('checked', 'checked');
            }
            else {
                target.prop('checked', false).removeAttr('checked');
            }
        });

        submitClick.attr('disabled', 'disabled');
        pobierz.attr('disabled', 'disabled');

        tagCheckbox.each(function (e) {
            var tag = $(this);

            if (tag.is(':checked')) {
                submitClick.removeAttr('disabled');
                pobierz.removeAttr('disabled');
            }
        });
    });

    //zablokowanie dostepu przy zaladowaniu strony
    //jesli nie sa zaznaczone opcje
    if (tagSelectCode.is(':checked') || tagSelectDate.is(':checked')) {
        text.removeAttr('disabled');

        tagCheckbox.each(function () {
            var target = $(this);
            target.removeAttr('disabled');
        });
                    

        text.removeAttr('disabled');

        if (tagSelectCode.is(':checked')) {
            submitClick.removeAttr('disabled');
            pobierz.removeAttr('disabled');
        }
        else if (tagSelectDate.is(':checked')) {
            tagData.removeAttr('disabled');

            submitClick.removeAttr('disabled');
            pobierz.removeAttr('disabled');
        }
        else {
            submitClick.attr('disabled', 'disabled');
            pobierz.attr('disabled', 'disabled');

            tagCheckbox.each(function (e) {
                var tag = $(this);

                if (tag.is(':checked')) {
                    submitClick.removeAttr('disabled');
                    pobierz.removeAttr('disabled');
                }
            });

            tagData.attr('disabled', 'disabled');

        }
    }
    else {
        tagCheckbox.each(function () {
            var target = $(this);
            if (!target.is(':checked'))
                target.attr('disabled', 'disabled');
        });

        text.attr('disabled', 'disabled');
        tagData.attr('disabled', 'disabled');
    }

    //blokowanie / odbkolowanie opcji wyszukiwnaia
    //po kodzie
    tagSelectCode.click(function (e) {
        var tag = $(this);

        if (tag.is(':checked')) {
            text.removeAttr('disabled');
        }
        else {
            text.attr('disabled', 'disabled');
        }

        tagCheckbox.each(function () {

            var target = $(this);
            target.prop('checked', false).removeAttr('checked');
            target.attr('disabled', 'disabled');
        });

        if (tagSelectDate.is(':checked')) {
            tagSelectDate.prop('checked', false).removeAttr('checked');
        }

        submitClick.removeAttr('disabled');
        pobierz.removeAttr('disabled');
    });

    //po dacie
    tagSelectDate.click(function (e) {
        var tag = $(this);

        if (tag.is(':checked')) {
            tagData.removeAttr('disabled');
            submitClick.removeAttr('disabled');
            pobierz.removeAttr('disabled');
        }
        else {
            tagData.attr('disabled', 'disabled');
            submitClick.attr('disabled', 'disabled');
            pobierz.attr('disabled', 'disabled');
        }

        tagCheckbox.each(function () {

            var target = $(this);

            if (tag.is(':checked')) {
                target.removeAttr('disabled');
            }
            else {
                target.prop('checked', false).removeAttr('checked');
                target.attr('disabled', 'disabled');
            }
        });

        if (tagSelectCode.is(':checked')) {
            tagSelectCode.prop('checked', false).removeAttr('checked');
        }
    });

    tagCheckbox.click(function () {
        submitClick.attr('disabled', 'disabled');
        pobierz.attr('disabled', 'disabled');

        tagCheckbox.each(function (e) {
            var tag = $(this);

            if (tag.is(':checked')) {
                submitClick.removeAttr('disabled');
                pobierz.removeAttr('disabled');
            }
        });
    });

})