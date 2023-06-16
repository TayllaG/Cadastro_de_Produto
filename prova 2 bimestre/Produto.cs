using System.Configuration;

public class Produto
{
    public string unidade;
    public double valor;
    public double pis;
    public double icms;
    public double confins;
    public double lucro;

    public Produto(string unidade, double valor, double pis, double icms, double confins, double lucro)
    {
        this.unidade = unidade;
        this.valor = valor;
        this.pis = pis;
        this.icms = icms;
        this.confins = confins;
        this.lucro = lucro;
    }

    public string CalcularValorF()
    {
        double somaIm = 0;
        double resultIm = 0;
        double resultLuc = 0;
        double resultVend = 0;
        if (unidade == "UN")
        {
            somaIm = pis + icms + confins;
            resultIm = valor + (valor* somaIm) / 100;
            resultLuc = (somaIm * lucro) / 100;
            resultVend = resultLuc + resultIm;
            return resultVend.ToString("C2");
        }
        else if(unidade == "LT" || unidade == "KL")
        {
            somaIm = pis + icms + confins;
            resultIm = valor + (valor * somaIm) / 100;
            resultLuc = (somaIm * lucro) / 100;
            resultVend = resultLuc + resultIm;
            double imLtKl = (resultVend * 5)/100;
            double result = resultVend + imLtKl;
            return  result.ToString("C2");
        }
        else
        {
            return "Unidade não foi selecionada!";
        }
    }
}
