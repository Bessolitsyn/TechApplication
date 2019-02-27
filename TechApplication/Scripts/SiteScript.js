
function show(elId, target) {

    //$('#' + elId).removeClass('height90px');
    //$('.' + elId).removeClass('col-md-3');
    //$('.' + elId).addClass('col-md-12');
    $('#' + elId).show()
    $('.image' + elId).hide();
    $(target).hide();
    var ParenNode = $(target).parent('.card-body .learn-moree')[0];
    $(ParenNode).find('.min').show();
    $('.' + elId).removeClass('card-img-overlay');
    //$('.card-img-overlay').removeClass('card-img-overlay')
    //$(elId).css('background-color', '#0b5b72');
    
};
function hide(elId, target) {
    //$('#' + elId).addClass('height90px');
    //$('.' + elId).removeClass('col-md-12');
    //$('.' + elId).addClass('col-md-3');
    $('#' + elId).hide()
    $('.image' + elId).show();
    $(target).hide();
    var ParenNode = $(target).parent('.card-body .learn-moree')[0];
    $(ParenNode).find('.max').show();
    $('.' + elId).addClass('card-img-overlay')
};

$(function () {
    $('.link').hover(
        function () {
        $(this).next().show(); // получаем следующий за данным .link элемент (т.е. span)
        },
        function () {
            $(this).next().hide();
        }
    );
    $('.imagep4').hover(
        function () {
            $(this).hide();
            alert(this);
        }
    );

});
