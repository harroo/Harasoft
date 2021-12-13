
dll:
	mcs -t:library -recurse:Harasoft/* -out:Harasoft_vX.dll

test:
	mcs -recurse:Harasoft/* Test.cs -out:Test.cil
