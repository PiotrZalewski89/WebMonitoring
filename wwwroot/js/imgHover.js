$('.imgChange').mouseenter(function (e) {
    var parent = $(this);
    var img = parent.children();


    if (parent.attr('id') === 'lineProduction') {
        img.attr("src", "/images/_factory2_32px.png");
    }
    else {
        img.attr("src", "/images/production_line_32px_1.png");
    }

});

$('.imgChange').mouseleave(function (e) {
    var parent = $(this);

    var img = parent.children();

    if (parent.attr('id') === 'lineProduction') {
        img.attr("src", "/images/_factory_32px.png");
    }
    else {
        img.attr("src", "/images/production_line_32px.png");
    }   

});