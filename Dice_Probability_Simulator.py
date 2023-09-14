import random

def roll_dice(n):
    return [random.randint(1, 6) for _ in range(n)]

def simulate(num_trials, num_dice):
    results = {i: 0 for i in range(num_dice, num_dice * 6 + 1)}
    for _ in range(num_trials):
        roll = sum(roll_dice(num_dice))
        results[roll] += 1
    return results

def print_results(results, num_trials):
    print("Total\tSimulated Percent")
    for total, count in sorted(results.items()):
        print("{}\t{:.2f}".format(total, 100 * count / num_trials))

def main():
    num_trials = int(input("Enter number of trials: "))
    num_dice = int(input("Enter number of dice: "))
    results = simulate(num_trials, num_dice)
    print_results(results, num_trials)

if __name__ == "__main__":
    main()