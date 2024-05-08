//document.querySelectorAll('.star-rating input').forEach(item => {
//    item.addEventListener('change', () => {
//        document.getElementById('ratingForm').submit();
//    });
//});

document.querySelectorAll('.star-rating input').forEach(item => {
    item.addEventListener('change', event => {
        alert('You rated this course ' + event.target.value + ' out of 5');
    });
});