//    Crie um programa que simule o funcionamento de um caixa eletrônico.
//    No início, pergunte ao usuário qual será o valor a ser sacado 
//    (número inteiro) e o programa vai informar quantas cédulas de 
//    cada valor serão entregues. OBS: considere que o caixa possui 
//    cédulas de R$50, R$20, R$10 e R$1.

Console.Write("Valor do saque: ");
var saque = int.Parse(Console.ReadLine());

Console.WriteLine($"Notas de cinquenta: {(saque - (saque % 50)) / 50}");

var resto = saque % 50;

if (resto >= 20) Console.WriteLine($"Notas de vinte: {(resto - (resto % 20)) / 20}");

resto %= 20;

if (resto >= 5) Console.WriteLine($"Notas de cinco: {(resto - (resto % 5)) / 5}");

resto %= 5;

if (resto >= 1) Console.WriteLine($"Notas de 1: {(resto - (resto % 1)) / 1}");