

$('#calendar').fullCalendar({
    events: [
        {
            title: 'event1',
            start: '2016-03-17'
        },
        {
            title: 'event2',
            start: '2010-01-05',
            end: '2016-03-16'
        },
        {
            title: 'event3',
            start: '2016-03-15 12:30:00',
            allDay: false // will make the time show
        }
    ]
});