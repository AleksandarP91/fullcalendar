$('#calendar').fullCalendar({
    dayClick: function (date, jsEvent, view) {
        view = '#calendar'
        alert('Clicked on: ' + date.format());

        alert('Coordinates: ' + jsEvent.pageX + ',' + jsEvent.pageY);

        alert('Current view: ' + view.name);

        // change the day's background color just for fun
        $(this).css('background-color', 'red');

    }
});

function dayBind(days) {
    days.click(dayClick)
        .mousedown(daySelectionMousedown);
}


function dayClick(ev) {
    if (!opt('selectable')) { // if selectable, SelectionManager will worry about dayClick
        var date = parseISO8601($(this).data('date'));
        trigger('dayClick', this, date, true, ev);
    }
}
