namespace EncontrarIndicePrimeiraOcorrencia.App.Algoritmos
{
    public static class AlgoritmoPrimeiraOcorrencia
    {
        public static int EncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo(int[] arr, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int EncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo(int[] arr, int inferior, int superior, int x, int n)
        {
            if (superior >= inferior)
            {
                int metade = inferior + (superior - inferior) / 2;
                if ((metade == 0 || x > arr[metade - 1]) && (arr[metade] == x))
                {
                    return metade;
                }
                else if (x > arr[metade])
                {
                    return EncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo(arr, metade + 1, superior, x, n);
                }
                else
                {
                    return EncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo(arr, inferior, metade - 1, x, n);
                }
            }
            return -1;
        }
    }
}