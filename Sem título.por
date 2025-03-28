programa
 {
  inclua biblioteca Util--> util
  funcao inicio()
   {

    inteiro i,num_aleatorio,par,x
    inteiro valores[15]
   par=0
    para(i=0;i<15;i++)
    {
      escreva(valores[i])
    x  = util.sorteia(1,100)
     valores[i] = x
        se(i==par)
        escreva(valores[i])
    }
    par+=2
 
  }
}
