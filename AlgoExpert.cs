class AlgoExpert {
    // Non Constructible Change
    // Given an array of positive integers representing the values of coins in your possession
    // write a function that returns the min amount of change that you cannot create
    // you can have multiple coins of the same value

    // coins [1, 2, 5] . min change you can't do is 4. 3 would be adding 1 and 2.
    // brute is to iterate through K (change) and see if it's possible to sum to K. would be O N^2
    public int NonConstructibleChange(int[] coins) {
        // sort the coins first since we are try to find the minimum
        Array.Sort(coins);

        // loop through coins. how much change can we make
        int change = 0;
        foreach (int coin in coins) {
            // if the current coin is ever bigger than the change we can make + 1
            if (coin > change + 1) {
                return change + 1;
            }
            change += coin;
            // say you have [1, 1, 4]. we can't make 3. you could do 2. 4 > 2 + 1
        }
        return change + 1; // at end. take all the change you can make. Then just add 1
        // O (N log N) time because sort and then loop
    }
}