dividor = int(input("Please enter a dividor: "))
arr = []
for i in range(1,dividor):
	if dividor%i == 0:
		arr.append(i)

print(arr)