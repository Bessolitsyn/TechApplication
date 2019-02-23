
function show(elId, target) {

    //$('#' + elId).removeClass('height90px');
    $('.' + elId).removeClass('col-md-4');
    $('.' + elId).addClass('col-md-12');
    $('#' + elId).show()
    $('.image' + elId).hide();
    $(target).hide();
    var ParenNode = $(target).parent('.card-body .learn-moree')[0];
    $(ParenNode).find('.min').show();
    //$(elId).css('background-color', '#0b5b72');
    
};
function hide(elId, target) {
    //$('#' + elId).addClass('height90px');
    $('.' + elId).removeClass('col-md-12');
    $('.' + elId).addClass('col-md-4');
    $('#' + elId).hide()
    $('.image' + elId).show();

    $(target).hide();
    var ParenNode = $(target).parent('.card-body .learn-moree')[0];
    $(ParenNode).find('.max').show();
    
};

$(function () {

});
