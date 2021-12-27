//Slider
const slider = document.querySelector('.slider');
const slides = document.querySelectorAll('.slide');
const btnLeft = document.querySelector('.slider__btn--left');
const btnRight = document.querySelector('.slider__btn--right');
let curSlide = 0;
const maxSlide = slides.length;
//slider.style.transform = 'scale(0.5) translateX(-800px)';
//slider.style.overflow = 'visible';
slides.forEach((s, i) => (s.style.transform = `translateX(${100 * i}%)`));
const goToSlide = function (slide) {
    slides.forEach((s, i) => (s.style.transform
        = `translateX(${100 * (i - slide)}%)`));
}
goToSlide(0);
// 0%, 100%, 200%, 300%
const nextSlide = function () {
    if (curSlide === maxSlide - 1) {
        curSlide = 0;
    } else {
        curSlide++;
    }
    goToSlide(curSlide);
};
const prevSlide = function () {
    if (curSlide === 0) {
        curSlide = maxSlide - 1;
    }
    curSlide--;
    goToSlide(curSlide);
};
btnRight.addEventListener('click', nextSlide);
btnLeft.addEventListener('click', prevSlide);