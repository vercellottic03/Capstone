// InfoAssuranceWeek2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <fstream>
#include <iostream>
#include <string>
#include <vector>

using namespace std;
vector<char> encrypt(int key, string line) {
	char blank = ' ';
	vector<char> alpha = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
	vector<char> lower = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
	vector<char> cipher;
	for (int i = 0;i < line.length();i++) {
		if (isupper(line[i])) {
			for (int j = 0;j < 26;j++) {
				if (line[i] == alpha[j]) {
					int shift = (j + key) % 26;
					cipher.push_back(alpha[shift]);
					break;
				}
			}
		}
		else if (islower(line[i])) {
			for (int j = 0;j < 26;j++) {
				if (line[i] == lower[j]) {
					int shift = (j + key) % 26;
					cipher.push_back(lower[shift]);
					break;
				}
			}
		}
		else if (line[i] == ' ') {
			cipher.push_back(blank);
		}
	}
	return cipher;
}

vector<char> decrypt(int key, string line) {
	char blank = ' ';
	vector<char> alpha = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
	vector<char> lower = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
	vector<char> plaintext;
	for (int i = 0;i < line.length();i++) {
		if (isupper(line[i])) {
			for (int j = 0;j < 26;j++) {
				if (line[i] == alpha[j]) {
					int shift = (j - key) % 26;
					plaintext.push_back(alpha[shift]);
					break;
				}
			}
		}
		else if (islower(line[i])) {
			for (int j = 0;j < 26;j++) {
				if (line[i] == lower[j]) {
					int shift = (j - key) % 26;
					plaintext.push_back(lower[shift]);
					break;
				}
			}
		}
		else if (line[i] == ' ') {
			plaintext.push_back(blank);
		}
	}
	return plaintext;
}
int main()
{
	ifstream filein("plaintext_in.txt");
	ifstream fileoutCipher("ciphertext_out.txt");
	ofstream fileout("ciphertext_out.txt");
	ofstream decryptIn("plaintext_out.txt");
	ifstream decryptOut("plaintext_out.txt");
	if (!filein)
	{
		cout << "Error opening input file" << std::endl;
		system("pause");
		return -1;
	}
	if (!fileout)
	{
		cout << "Error opening output file" << std::endl;
		system("pause");
		return -1;
	}
	string strIn;
	string strOut;
	int keyEncrypt;
	int keyDecrypt;
	vector<string> plaintextIn;
	while (getline(filein, strIn)) {
		plaintextIn.push_back(strIn);
	}
	filein.close();
	cout << "Please enter a number you would like to shift the characters by: ";
	cin >> keyEncrypt;
	cout << "Generating Ciphertext......." << endl;
	for (int i=0; i < plaintextIn.size(); i++) {
		vector<char>crypto1 = encrypt(keyEncrypt, plaintextIn[i]);
		for (int i = 0;i < crypto1.size();i++) {
			fileout << crypto1[i];
		}
		fileout << "\n";
	}
	fileout.close();
	vector<string> ciphertextIn;
	if(fileoutCipher.is_open()){
		cout << "Outputted ciper:" << endl;
		while (getline(fileoutCipher, strOut)) {
			cout << strOut << '\n';
			ciphertextIn.push_back(strOut);
		}
	} else {
		cout << "cant output cipher" << endl;
	}
	cout << "Vector populated for decryption" << endl;
	cout << "Please enter a number to shift the bits of the cipher: ";
	cin >> keyDecrypt;
	cout << "Decrypting ciphertext......." << endl;
	for (int i = 0; i < ciphertextIn.size(); i++) {
		vector<char>crypto2 = decrypt(keyDecrypt, plaintextIn[i]);
		for (int i = 0;i < crypto2.size();i++) {
			decryptIn << crypto2[i];
		}
		decryptIn << "\n";
	}
	decryptIn.close();
	string finalOut;
	if (decryptOut.is_open()) {
		cout << "Decrypted Message....:" << endl;
		while (getline(decryptOut, finalOut)) {
			cout << finalOut << '\n';
		}
	}
	else {
		cout << "cant output cipher" << endl;
	}
    return 0;
}

