class Misc {
    // Calculate Nth fibonacci number using recursion
    public int fibonacci(int n) {
        if (n <= 1) {
            return n;
        } else {
            return fibonacci(n - 2) + fibonacci(n - 1);
        }
    }

    // Calculate Nth fibonacci number using iteration
    public int fibonacciIterate(int n) {
        int numOne = 0, numTwo = 1, sum = 0;

        for (int i = 0; i < n; i++) {
            sum = numOne + numTwo;
            numOne = numTwo;
            numTwo = sum;
        }
        return numOne;
    }
}