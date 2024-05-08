document.querySelectorAll('.star-rating input').forEach(item => {
    item.addEventListener('change', () => {
        document.getElementById('ratingForm').submit();
    });
});