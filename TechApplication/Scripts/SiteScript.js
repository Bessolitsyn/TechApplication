
function show(elId, target) {

    $(elId).css('height', '100%');
    $(target).hide();
    var ParenNode = $(target).parent('.learn-moree')[0];
    $(ParenNode).find('.min').show();
    //$(elId).css('background-color', '#0b5b72');
    
};
function hide(elId, target) {
    $(elId).css('height', '70px');
    $(target).hide();
    var ParenNode = $(target).parent('.learn-moree')[0];
    $(ParenNode).find('.max').show();
    
};

$(function () {

});
