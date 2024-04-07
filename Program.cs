double percentualBonus, percentualRetorno;
int pontosTransferir, PontosReduzir, pontosAcrescentar;

Console.Clear();

Console.WriteLine("Milhas Bumerangue");
Console.WriteLine();

Console.Write("Percentual de bônus.........: ");
percentualBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno.......: ");
percentualRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual a transferir.....: ");
pontosTransferir = Convert.ToInt32(Console.ReadLine());

PontosReduzir = Convert.ToInt32(pontosTransferir - (percentualRetorno / 100) * pontosTransferir);
pontosAcrescentar = Convert.ToInt32(pontosTransferir + (percentualBonus / 100) * pontosTransferir);

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {PontosReduzir}");
Console.WriteLine($"Pontos a acrescentar no destino...: {pontosAcrescentar}");
