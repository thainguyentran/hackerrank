arr = []
for arr_i in range(6):
   arr_t = [int(arr_temp) for arr_temp in input().strip().split(' ')]
   arr.append(arr_t)
#in case each value is less than 0
hourglass_sum = maxsum = -63;
#arr[i][j: j + 3] retrieve the values from range e.g.: 0->2
for i in range(4):
    for j in range(4):
        hourglass_sum = sum(arr[i][j: j + 3]) + arr[i + 1][j + 1] + sum(arr[i + 2][j: j + 3])
        if maxsum < hourglass_sum:
            maxsum = hourglass_sum
print(maxsum)
