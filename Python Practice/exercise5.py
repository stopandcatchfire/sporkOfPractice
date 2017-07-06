import random

a = []
b = []
c = []

int1 = int(input("Enter number of entries in list1: "))
int2 = int(input("Enter number of entries in list2: "))

for i in range(0,int1):
	a.append(random.randint(0,9))

for i in range(0,int2):
	b.append(random.randint(0,9))

a.sort()
b.sort()

for num in a:
	if num in b:
		c.append(num)
		
print(c)
