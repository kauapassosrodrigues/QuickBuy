import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}}</body></html>"
})                              
export class ProdutoComponent { // Nome das classes começando com maiúculos por conta da convenção PascalCase

  /* camelCase para variaveis, atributos e nomes das fucções*/
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }
}
