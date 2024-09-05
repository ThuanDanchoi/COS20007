def Average(num):
    if not num:
         
        return None
    
    total = 0
    count = 0

    for i in num:
        total += i
        count += 1

    average = total / count
    return average

def main():
  
    data = [12, 14, 16, 18, 20]

     
    result = Average(data)

     
    if result is not None:
        print(f"The average of the numbers is: {result}") # formatting string

        
        if result >= 10:
            print("Double digits")
        else:
            print("Single digits")

         
        if result < 0:
            print("Average value is in the negative.")
    else:
        print("The array is empty, cannot calculate the average.")

main()
