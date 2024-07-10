function createClassRoom(numberOfStudents) {
    function studentSeat(seat) {
        return function() {
            return seat;
        };
    }

    var students = [];

    for (var primary = 0; primary < numberOfStudents; primary++) {
        students.push(studentSeat(primary + 1));
    }

    return students;
}

var classRoom = createClassRoom(10);

for (var secondary = 0; secondary < classRoom.length; secondary++) {
    console.log(classRoom[secondary]());
}
