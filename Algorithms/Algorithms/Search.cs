namespace Algorithms;

public class Search
{
    public int BinarySearch(int[] array, int target)
    {
        // Define os limites inicial (low) e final (high) do array
        int low = 0;    
        int high = array.Length - 1;

        // Executa o loop enquanto o intervalo de busca for válido
        while (low <= high)
        {
            // Calcula o índice do meio do intervalo atual
            // Atenção: Para evitar overflow em arrays grandes, é comum usar:
            // int mid = low + (high - low) / 2;
            int mid = (low + high) / 2;

            // Obtém o valor no meio do intervalo atual
            int order = array[mid];

            // Verifica se o elemento no meio é o alvo
            if (order == target)
            {
                return mid; // Retorna o índice do elemento encontrado
            }

            // Se o valor no meio for maior que o alvo,
            // ajusta o limite superior para procurar na metade inferior
            if (order > target)
            {
                high = mid - 1;
            }
            // Caso contrário, ajusta o limite inferior para buscar na metade superior
            else
            {
                low = mid + 1;
            }
        } 

        // Se o loop terminar sem encontrar o alvo, retorna -1
        return -1;
    }


}