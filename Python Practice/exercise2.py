number = int(input("Enter a number: "))
if number%2 == 0:
	print("number is even")		
else:
	print("number is odd")
	
if number%4 == 0:
	print("number is multiple of 4 ")
	
print("\n\n\n\n")

number = int(input("Enter a new number: "))
check = int(input("enter checking number to divide first with: "))

if number%check == 0:
	print("divides evenly!")
else:
	print("doesnt di vide evenly :(")