all:derle bagla calistir
derle:
	g++ -c -I "./include" ./src/Test.cpp -o ./lib/Test.o
	g++ -c -I "./include" ./src/AVLAgaci.cpp -o ./lib/AVLAgaci.o
	g++ -c -I "./include" ./src/Dugum.cpp -o ./lib/Dugum.o	
	g++ -c -I "./include" ./src/DugumAvl.cpp -o ./lib/DugumAvl.o
	g++ -c -I "./include" ./src/DogruKuyrugu.cpp -o ./lib/DogruKuyrugu.o	
bagla:
	g++ ./lib/Dugum.o ./lib/AVLAgaci.o ./lib/Test.o ./lib/DogruKuyrugu.o ./lib/DugumAvl.o -o ./bin/program
calistir:
	./bin/program