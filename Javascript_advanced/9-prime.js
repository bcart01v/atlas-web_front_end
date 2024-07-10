function countPrimeNumbers() {
    function isPrime(num) {
        if (num <= 1) return false;
        if (num <= 3) return true;
        if (num % 2 === 0 || num % 3 === 0) return false;
        for (let count = 5; count * count <= num; count += 6) {
            if (num % count === 0 || num % (count + 2) === 0) return false;
        }
        return true;
    }

    let count2 = 0;
    for (let count = 2; count <= 100; count++) {
        if (isPrime(count)) {
            count2 += 1;
        }
    }
    return count2;
}


const start = performance.now();
const primeCount = countPrimeNumbers();
const end = performance.now();

console.log(`Execution time of printing countPrimeNumbers was ${end - start} milliseconds.`);