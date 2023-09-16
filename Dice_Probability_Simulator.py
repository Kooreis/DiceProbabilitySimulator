def simulate(num_trials, num_dice):
    results = {i: 0 for i in range(num_dice, num_dice * 6 + 1)}
    for _ in range(num_trials):
        roll = sum(roll_dice(num_dice))
        results[roll] += 1
    return results