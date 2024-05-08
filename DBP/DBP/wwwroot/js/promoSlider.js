document.addEventListener('DOMContentLoaded', function () {
    const slidesContainer = document.querySelector('.slides');
    let index = 0;
    const totalSlides = 6;
    let slideInterval;

    function showSlide(idx) {
        slidesContainer.style.transform = `translateX(-${idx * 50}%)`;
    }

    function startSlideTimer() {
        clearInterval(slideInterval); // Clear existing interval
        slideInterval = setInterval(function () { // Start a new interval
            index = (index + 1) % totalSlides;
            showSlide(index);
        }, 4000);
    }

    document.querySelector('.prev').addEventListener('click', function () {
        index = (index > 0) ? index - 1 : totalSlides - 1;
        showSlide(index);
        startSlideTimer(); // Reset the timer when user manually changes slide
    });

    document.querySelector('.next').addEventListener('click', function () {
        index = (index + 1) % totalSlides;
        showSlide(index);
        startSlideTimer(); // Reset the timer when user manually changes slide
    });

    startSlideTimer(); // Initialize the timer
});