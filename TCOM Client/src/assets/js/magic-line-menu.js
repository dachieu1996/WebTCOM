$(function() {

    var $el, leftPos, newWidth,
        $mainNav = $(".list-menu-header");
    
    $mainNav.append("<li id='magic-line'></li>");
    var $magicLine = $("#magic-line");
    
    $magicLine
        .width($(".list-menu-header .current_page_item a").width())
        .css("left", $(".list-menu-header .current_page_item a").position().left + 30)
        .data("origLeft", $magicLine.position().left)
        .data("origWidth", $magicLine.width());
        
    $(".list-menu-header li a").hover(function() {
        $el = $(this);
        leftPos = $el.position().left + 30;
        newWidth = $el.parent().innerWidth() - 60;
        $magicLine.stop().animate({
            left: leftPos,
            width: newWidth
        });
    }, function() {
        $magicLine.stop().animate({
            left: $magicLine.data("origLeft"),
            width: $magicLine.data("origWidth")
        });    
    });
});