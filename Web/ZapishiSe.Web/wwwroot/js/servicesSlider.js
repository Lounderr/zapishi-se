$('.slider').slick({
    centerMode: true,
    centerPadding: '22vw',
    slidesToShow: 1,
    slidesToScroll: 1,
    dots: false,
    arrows: false,
    centerMode: true,
    focusOnSelect: true,
    autoplay: true,
    autoplaySpeed: 3000,
    dotsClass: 'slick-dots',
    pauseOnHover: true,
    adaptiveHeight: true,
    speed: 700,
    infinite: true,

    responsive: [
        {
            breakpoint: 800,
            settings: {
                centerPadding: '0px',
                centerMode: false,
                arrows: true,
            }
        }
    ]
});