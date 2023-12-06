// script.js

// Example: Add functionality for slider navigation
document.addEventListener('DOMContentLoaded', function () {
    const sliderContainer = document.querySelector('.uk-slider-container-offset');
    const sliderItems = document.querySelector('.uk-slider-items');

    let currentIndex = 0;

    document.querySelector('.uk-position-center-left').addEventListener('click', function () {
        if (currentIndex > 0) {
            currentIndex--;
            updateSliderTransform();
        }
    });

    document.querySelector('.uk-position-center-right').addEventListener('click', function () {
        if (currentIndex < sliderItems.children.length - 1) {
            currentIndex++;
            updateSliderTransform();
        }
    });

    function updateSliderTransform() {
        const itemWidth = sliderItems.children[0].offsetWidth;
        sliderItems.style.transform = `translateX(-${currentIndex * itemWidth}px)`;
    }
});
