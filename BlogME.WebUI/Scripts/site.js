// Add listener for tag removals
$(document).on('click', '.tag-cloud', function () { $(this).remove(); });

$(document).ready(function () {
    $('#tag > div > div > label').click(function () { addTag('#tag'); });
    $('#tag > div > div > input').keyup(function (e) { if (e.keyCode === 13) { addTag('#tag'); } });
});

function addTag(id) {
    var tag = $(id + ' > div > div > input').val();

    // If there is no value in the input field then don't do anything
    if (tag !== '') {
        // Append tag into the tag cloud 
        $('<li class="tag-cloud">' + tag + '</li>').appendTo("#tag-cloud");
        // Clear input back to nothing
        $(id + ' > div > div > input').val('');
    }
}