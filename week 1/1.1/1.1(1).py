def Average(num):
     
    if not num:
        return 0   

    total = 0
    count = 0

     
    for i in num:
        total += i
        count += 1

     
    average = total / count

    # Print additional message based on the average
    if average >= 10:
        print("Double digits")
    else:
        print("Single digits")

    return average


num = [0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

#Average function and store the result in a variable
result = Average(num)

# print result
print("The average is:", result)



