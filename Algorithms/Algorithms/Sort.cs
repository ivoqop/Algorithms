namespace Algorithms;

public class Sort
{
    public void SelectionSort(int[] array)
    {
        for (var i = 0; i < (array.Length - 1); i++)
        {
            // Assume que o menor elemento está na posição i
            var minIndex = i;

            // Encontra o índice do menor elemento no restante do array
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Troca o menor elemento encontrado com o elemento na posição i
            if (minIndex != i)
            {
                //Swap: Durante a execução, os valores das duas posições são "trocados" de forma segura, sem a necessidade de uma variável temporária.
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
        }
    }

    


}