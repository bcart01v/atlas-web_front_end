    function divideBy(firstNumber) {
        return function(secondNumber) {
            return secondNumber / firstNumber;
        };
    }

    function addBy(firstNumber) {
        return function(secondnumber) {
            return firstNumber + secondnumber;
        }
    }

    var addBy100 = addBy(100);
    var addBy1000 = addBy(1000);

    var divideBy10 = dividedBy(10);
    var divideBy100 = dividedBy(100);