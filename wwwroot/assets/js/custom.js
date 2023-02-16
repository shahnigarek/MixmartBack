//-----------Add To Bask ------
$(document).on('click', '.subCount', function (e) {
    e.preventDefault();

    let count = $(this).next().val();

    if (count > 1) {
        count--;
        $(this).next().val(count)

        let url = $(this).attr('href') + '?count=' + count;
        console.log(url)
        fetch(url)
            .then(res => res.text())
            .then(data => {
                $('.baskett').html(data);
                fetch('/basket/getbasket')
                    .then(res => res.text())
                    .then(data => { $('.cart').html(data) });
            })
    }
})

$(document).on('click', '.addCount', function (e) {
    e.preventDefault();

    let count = $(this).prev().val();

    if (count < 1) {
        count = 1
    }

    count++;
    $(this).prev().val(count)

    let url = $(this).attr('href') + '?count=' + count;
    console.log(url)
    fetch(url)
        .then(res => res.text())
        .then(data => {
            $('.baskett').html(data);
            fetch('/basket/getbasket')
                .then(res => res.text())
                .then(data => { $('.cart').html(data) });
        })
})


$(document).on('click', '.addbasket', function (e) {
    e.preventDefault();

    let url = $(this).attr('href');

    fetch(url)
        .then(res => res.text())
        .then(data => {
            $('.cart').html(data);
        });
})


$(document).on('click', '.addtowishlist', function (e) {
    e.preventDefault();

    let url = $(this).attr('href');

    fetch(url)
        .then(res => res.text())
        .then(data => {
            $('.wishlistt').html(data);
        });
})

$(document).on('click', '.deletebasket', function (e) {
    e.preventDefault();


    fetch($(this).attr('href'))
        .then(res => res.text())
        .then(data => { $('.baskett').html(data) });
})

$(document).on('click', '.deletewishlist', function (e) {
    e.preventDefault();

    fetch($(this).attr('href'))
        .then(res => res.text())
        .then(data => { $('.wishlistt').html(data) });
})
$(document).on('click', '.product-close', function (e) {
    e.preventDefault();


    fetch($(this).attr('href'))
        .then(res => res.text())
        .then(data => { $('.cart').html(data) });
})