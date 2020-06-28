$(function(){
	//fix height header
	function fixHead() {
		var x = $(window).height();
		if(x >= 700) {
			$('.group-head').height(x);
		}
	}
	fixHead();
	$(window).resize(function(event) {
		fixHead();
	});

	//scroll fix header
	$(window).scroll(function(){
		var x = $(window).scrollTop();
		if(x > $('.header').height() + 10) {
			$('.header-contain').addClass('fix');
		} else {
			$('.header-contain').removeClass('fix');
		}
	});
	//detect scroll up down
	var lastScrollTop = 0;
	$(window).scroll(function(event){
		var st = $(this).scrollTop();
		if (st > lastScrollTop){
			// downscroll code
			$('.header-contain').removeClass('header-contain-show').addClass('header-contain-hidden');
		} else {
			// upscroll code
			$('.header-contain').removeClass('header-contain-hidden').addClass('header-contain-show');
		}
		lastScrollTop = st;
	});
	$('#loader').fadeOut(1000);
	$('html,body').scrollTop(0);
	$('html,body').animate({scrollTop:0}, 500);

	$('.btn-language').click(function(e){
		e.preventDefault();
		var url = window.location.href;
		var lang = $(this).attr('data-lang');
		lang = lang ? '/' + lang : '';

		url = url.replace('/vi', lang);
		console.log(url);
		window.location.href = url;
	});
});