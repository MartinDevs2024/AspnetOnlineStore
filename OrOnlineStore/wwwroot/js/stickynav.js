$(document).ready(function () {
    // sticky navigation menu

    let nav_offset_top = $(".navbar").height() + 50;

    function navbarFixed() {
        if ($(".navbar").length) {
            $(window).scroll(function () {
                let scroll = $(window).scrollTop();
                if (scroll >= nav_offset_top) {
                    $('.navbar').addClass('navbar_fixed');
                } else {
                    $('.navbar').removeClass('navbar_fixed');
                }

            });
        }
    }
    navbarFixed();

});