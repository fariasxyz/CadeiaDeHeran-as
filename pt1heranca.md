# **Aula: Herança, Classe Abstrata, Método Virtual, Método Abstrato, Interface e Classe/Método Estático**

## **1. Herança**

**Herança** é um dos pilares da **Programação Orientada a Objetos (POO)**. Ela permite que uma classe "filha" herde comportamentos e propriedades de uma classe "pai". A classe filha pode **reutilizar** o código da classe pai e ainda **adicionar ou modificar** seu próprio comportamento.

### Exemplo:

[![](https://mermaid.ink/img/pako:eNplUcFOwzAM_ZXIJ6Z1PxBxQQMhpI3LbigXqwmtRRNPbjoJjf47ybKOAL44ee_56cU5Q8vWgYZ2wHF8JOwEvQkq1UMgj4O6_9ps1BbbnkX4P_OMMaEFv3gs7Llgudav7J3SaoxCoVMV8WLRZoZCrNBtksvdSp2YbAU_eYokB_aJKlaFnEurMyx5byHWO0yzvzzneiA_40e8J_yjhQZSJo9k064uQgOxd94Z0OloUT4MmJB1OEU-fIYWdJTJNSA8dT3odxzGdJuOFqO7LvqGOkuRZX_9itwaOGJ4Y1408zc8NIK1?type=png)](https://mermaid.live/edit#pako:eNplUcFOwzAM_ZXIJ6Z1PxBxQQMhpI3LbigXqwmtRRNPbjoJjf47ybKOAL44ee_56cU5Q8vWgYZ2wHF8JOwEvQkq1UMgj4O6_9ps1BbbnkX4P_OMMaEFv3gs7Llgudav7J3SaoxCoVMV8WLRZoZCrNBtksvdSp2YbAU_eYokB_aJKlaFnEurMyx5byHWO0yzvzzneiA_40e8J_yjhQZSJo9k064uQgOxd94Z0OloUT4MmJB1OEU-fIYWdJTJNSA8dT3odxzGdJuOFqO7LvqGOkuRZX_9itwaOGJ4Y1408zc8NIK1)

```csharp
public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }

    public void EmitirSom()
    {
        Console.WriteLine("O animal fez barulho.");
    }
}

public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("O cachorro latiu.");
    }
}

public class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine("O gato miou.");
    }
}
```

Nesse exemplo, as classes `Cachorro` e `Gato` herdam os atributos `Nome` e `Idade`, bem como os métodos `Comer()` e `EmitirSom()` da classe `Animal`, mas eles também tem seus próprios métodos `Latir()` e `Miar()`.

### **Utilidade da herança:**

- **Reutilização de código**: Não é preciso escrever o mesmo código várias vezes para classes semelhantes.
- **Facilita a manutenção**: Ao modificar a classe pai, as mudanças se refletem em todas as classes filhas.

### Exercício

Implementem as seguintes classes e instanciem um objeto de cada uma delas, podem usar construtores se preferirem, lembrando que o método ToString() deve ser sobrescrito como comentado em uma das aulas anteriores.

[![](https://mermaid.ink/img/pako:eNp1kc9OwzAMxl8l8gm07gWiHRGchoSKOEy5mNp0EY09pQkSGnt30j8b7QFfnPj7frHlnKFRYrDQdNj3Dx7biMGJKfGYpfEqGL2a3c92a544siT-R31jISaNTibD-ODKdp6EITbPGthY06fopV3Ua-xGrzWk-b3jhfSq9ei-u19hlyktm86D3vpt9iiEsYBf6mmFTcB19j_iJaMkT0g8aNiXgbykGYUKAseAnsriRsZBOnJgB7YcS6tPB04GH-ak9bc0YFPMXEHU3B7BfmDXl1s-ESaet36rMvmkcT__y5AqOKEcVK-eyy8OEIwo?type=png)](https://mermaid.live/edit#pako:eNp1kc9OwzAMxl8l8gm07gWiHRGchoSKOEy5mNp0EY09pQkSGnt30j8b7QFfnPj7frHlnKFRYrDQdNj3Dx7biMGJKfGYpfEqGL2a3c92a544siT-R31jISaNTibD-ODKdp6EITbPGthY06fopV3Ua-xGrzWk-b3jhfSq9ei-u19hlyktm86D3vpt9iiEsYBf6mmFTcB19j_iJaMkT0g8aNiXgbykGYUKAseAnsriRsZBOnJgB7YcS6tPB04GH-ak9bc0YFPMXEHU3B7BfmDXl1s-ESaet36rMvmkcT__y5AqOKEcVK-eyy8OEIwo)

---

## **2. Classe Abstrata**

### **O que é?**

Uma **classe abstrata** é uma classe que não pode ser instanciada diretamente (ou seja, você não pode criar objetos dela). Ela é projetada para servir de **base** para outras classes e pode conter tanto métodos com implementação quanto métodos **abstratos** (que não têm implementação e devem ser implementados pelas subclasses).

### **Qual a utilidade?**

A utilidade de uma classe abstrata é **forçar uma hierarquia** e garantir que certas classes sigam um **modelo comum**. Ela é usada quando você quer definir comportamentos padrão para um grupo de classes, mas espera que as classes derivadas implementem ou sobrescrevam alguns desses comportamentos.

### Exemplo:
[![](https://mermaid.ink/img/pako:eNplkcFqwzAMhl_F6LTR9AVMKJRujMG6S28jF832EtPYKo5TKF3efXLdtN7mi-zv_yUk-QyKtAEJqsdheLLYBnSNF3zW3jrsRf29XIoNqo5CoP_KC0ammV9qzOo5s3Tqev05xIAqrlZ3ungnZ4QUrFjfikJ41aiTYn0s6Ibt4eFRHMnqAj87G23YkWMpl8rilEPZ2TzFrbXFG3Lur5pTmZCGu5u3Fv94oQLuyaHVvMGLsYHYGWcakHzVGPYNND75cIy0O3kFMobRVBBobDuQX9gP_BoPGqO5rv9GjbaRwvb6QSlUcED_QTR7ph_FM4in?type=png)](https://mermaid.live/edit#pako:eNplkcFqwzAMhl_F6LTR9AVMKJRujMG6S28jF832EtPYKo5TKF3efXLdtN7mi-zv_yUk-QyKtAEJqsdheLLYBnSNF3zW3jrsRf29XIoNqo5CoP_KC0ammV9qzOo5s3Tqev05xIAqrlZ3ungnZ4QUrFjfikJ41aiTYn0s6Ibt4eFRHMnqAj87G23YkWMpl8rilEPZ2TzFrbXFG3Lur5pTmZCGu5u3Fv94oQLuyaHVvMGLsYHYGWcakHzVGPYNND75cIy0O3kFMobRVBBobDuQX9gP_BoPGqO5rv9GjbaRwvb6QSlUcED_QTR7ph_FM4in)

```csharp
// No código só mudou esse abstract
public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }

    public void EmitirSom()
    {
        Console.WriteLine("O animal fez barulho.");
    }
}

public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("O cachorro latiu.");
    }
}

public class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine("O gato miou.");
    }
}
```
Aqui, a classe `Animal` é abstrata, ou seja, não podemos criar um objeto do tipo Animal, mas ela existe para manter toda a organização que a herança permite de que todo cachorro e gato tem que ter determinados atributos e métodos.

### Exercício

Adaptem o exercício anterior seguindo esse diagrama:
[![](https://mermaid.ink/img/pako:eNp1UU1rwzAM_StGp42mf8CEwmBspw5Gxg7DFzXSUrNEKo49GF3_-5yPfuQwXWTpvSc_W0eolRgs1C32_aPHJmDnxOR4SlJ7FQxeTfm7XptnDiyR_0HfWYhJg5OJMA5c0I4TMERZPuz6GLCOm821u3rRjo01GfHS3PQrbMcJ1pCmXcs30JtWI_vufiE7TenWymz_4mK1RSEMWfitnhaySXB-0VXxmlCiJyQeMOyzIS9xlkIBHYcOPeXvHDUO4p47dmDzMV_15cDJwMMUtfqRGmwMiQsImpo92E9s-1ylA2HkeReXLpOPGrbztoZUwAHlQ_XMOf0BJGiSGg?type=png)](https://mermaid.live/edit#pako:eNp1UU1rwzAM_StGp42mf8CEwmBspw5Gxg7DFzXSUrNEKo49GF3_-5yPfuQwXWTpvSc_W0eolRgs1C32_aPHJmDnxOR4SlJ7FQxeTfm7XptnDiyR_0HfWYhJg5OJMA5c0I4TMERZPuz6GLCOm821u3rRjo01GfHS3PQrbMcJ1pCmXcs30JtWI_vufiE7TenWymz_4mK1RSEMWfitnhaySXB-0VXxmlCiJyQeMOyzIS9xlkIBHYcOPeXvHDUO4p47dmDzMV_15cDJwMMUtfqRGmwMiQsImpo92E9s-1ylA2HkeReXLpOPGrbztoZUwAHlQ_XMOf0BJGiSGg)

---

## **3. Método Virtual**

### **O que é?**

Um **método virtual** é um método que **pode ser sobrescrito** (modificado) em uma classe derivada, mas **não precisa ser**. Ele já possui uma implementação padrão, e cabe às subclasses decidirem se querem mantê-la ou redefini-la.

### **Qual a utilidade?**

A utilidade dos métodos virtuais é que eles permitem uma **flexibilidade controlada**. Ou seja, a classe filha **pode sobrescrever o método**, mas não é forçada a isso. Assim, temos uma implementação padrão na classe pai, que pode ser customizada apenas quando necessário.

### Exemplo:
[![](https://mermaid.ink/img/pako:eNplUc1uwyAMfhXk037SF0BRpaqbph26S28TFw9YghpwRZxJU5d3H5SkTVVfDN8P-oxPoMlYkKA77PsXh01Er4JItQnOYyfqv9VKbFG3FCPdM2_ICS34-Y2ZPRUsV11vvnqOqHm9vqLPH-StkCIxLjRiQbwbNJlxgRfoNsnjw6P4IWcW8Kt37OKe_EQ9FW4sbRlsHuKS7M57Yy2mPN_VsHN4G2GEClIsj86kTzwLFXBrvVUg09FgPChQIetwYNr_Bg2S42AriDQ0Lchv7Pp0G44G2U4buKDWOKa4m3aUWwVHDJ9Es2b8BzsTiYk?type=png)](https://mermaid.live/edit#pako:eNplUc1uwyAMfhXk037SF0BRpaqbph26S28TFw9YghpwRZxJU5d3H5SkTVVfDN8P-oxPoMlYkKA77PsXh01Er4JItQnOYyfqv9VKbFG3FCPdM2_ICS34-Y2ZPRUsV11vvnqOqHm9vqLPH-StkCIxLjRiQbwbNJlxgRfoNsnjw6P4IWcW8Kt37OKe_EQ9FW4sbRlsHuKS7M57Yy2mPN_VsHN4G2GEClIsj86kTzwLFXBrvVUg09FgPChQIetwYNr_Bg2S42AriDQ0Lchv7Pp0G44G2U4buKDWOKa4m3aUWwVHDJ9Es2b8BzsTiYk)
```csharp
public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal fez barulho.");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro latiu.");
        // ou, se quiser que ele faça o que o virtual já fazia:
        base.EmitirSom();
    }
}

public class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine("O gato miou.");
    }
}
```

Aqui, `FazerSom()` na classe `Animal` tem uma implementação, mas `Cachorro` sobrescreve o método para fornecer seu próprio comportamento, inclusive nesse caso o método `Latir()` nem precisa mais existir.

### Exercício
Adicionem esse novo método virtual com uma implementação na classe Funcionário e outra na classe Vendedor.

[![](https://mermaid.ink/img/pako:eNp1UU1PwzAM_SuRT8C6PxBxRHAa0lTEAeXi1aaNaO0pTZDQ2H8n_VjpkPDFsd_z03N8gkqJwULVYt8_eKwDdk5MjscklVfB4NXcf2-35okDS-R_0FcWYtLgZCKMgle00wQMsXnWjo01fQxe6lW_xHbkWkOaDi2voJeAB2wbDDe35lM93a0xLUelDK0lz1NaG5qXWLxsdii0aF6NTQOXvX4n9gklekLiAcM-m_USF_ivz1kTCug4dOgp__Yo5iA23LEDm5_Zw4cDJwMPU9TySyqwMSQuIGiqG7Dv2Pa5SkfCyPOpli6Tjxp28zGHVMAR5U31wjn_AOY7m2Q?type=png)](https://mermaid.live/edit#pako:eNp1UU1PwzAM_SuRT8C6PxBxRHAa0lTEAeXi1aaNaO0pTZDQ2H8n_VjpkPDFsd_z03N8gkqJwULVYt8_eKwDdk5MjscklVfB4NXcf2-35okDS-R_0FcWYtLgZCKMgle00wQMsXnWjo01fQxe6lW_xHbkWkOaDi2voJeAB2wbDDe35lM93a0xLUelDK0lz1NaG5qXWLxsdii0aF6NTQOXvX4n9gklekLiAcM-m_USF_ivz1kTCug4dOgp__Yo5iA23LEDm5_Zw4cDJwMPU9TySyqwMSQuIGiqG7Dv2Pa5SkfCyPOpli6Tjxp28zGHVMAR5U31wjn_AOY7m2Q)


---

## **4. Método Abstrato**

### **O que é?**

Um **método abstrato** é um método declarado em uma **classe abstrata**, que **não tem implementação**. Ele **obriga** todas as classes que herdam da classe abstrata a fornecer uma implementação própria.

### **Qual a diferença para o método virtual?**

- Um método **virtual** já tem uma implementação e **pode** ser sobrescrito.
- Um método **abstrato** **não tem implementação** e **deve** ser sobrescrito pela classe filha.

### **Qual a utilidade?**

Métodos abstratos são usados para **forçar** que subclasses implementem comportamentos específicos, garantindo que classes derivadas sempre forneçam sua própria versão do método.

### Exemplo:

[![](https://mermaid.ink/img/pako:eNqFUc1OwzAMfpXIJ366F4iqSdNAiANcdkO5mCS00Zp4cl0kNPbupEs7inbAFyffT_Q5PoIl50GD7bDvHwI2jNEklWuTQsRO1d-rldqibYmZrpknlIwW_PzGzB4LNlZdb957YbSyXv-i968UvdIqMyE1akE8O3QjE5Is0G2W882t-qTgFvBjDBJ4R3Gi7gp3Km0ZbB7ikuzK-8daTON8_xqggpwtYnD5J89qA9L66A3ofHTIewMmjTochHZfyYIWHnwFTEPTgv7Ars-34eBQ_LSGC-pdEOKXaVFjq-CA6Y1o1px-ACrMi5k?type=png)](https://mermaid.live/edit#pako:eNqFUc1OwzAMfpXIJ366F4iqSdNAiANcdkO5mCS00Zp4cl0kNPbupEs7inbAFyffT_Q5PoIl50GD7bDvHwI2jNEklWuTQsRO1d-rldqibYmZrpknlIwW_PzGzB4LNlZdb957YbSyXv-i968UvdIqMyE1akE8O3QjE5Is0G2W882t-qTgFvBjDBJ4R3Gi7gp3Km0ZbB7ikuzK-8daTON8_xqggpwtYnD5J89qA9L66A3ofHTIewMmjTochHZfyYIWHnwFTEPTgv7Ars-34eBQ_LSGC-pdEOKXaVFjq-CA6Y1o1px-ACrMi5k)

```csharp
public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }

    public abstract void EmitirSom();
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro latiu.");

    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato miou.");
    }
}
```

Aqui, qualquer classe que herdar de `Animal` **deve** implementar o método `FazerSom()`, não tem opção, por isso o gato também sobrescreve o método.

### Exercício

Adicionem esse outro método abstrato e implementem ele nas classes filhas de formas diferentes.

[![](https://mermaid.ink/img/pako:eNqFUk1PwzAM_SuRT8C2PxBxA8FpSKiIA8rFa7w2WmNPaYKExv476ce6bgLhixO_p_fsOAcoxRJoKBts20eHVUBvWOV4Slw6YQxO1P33aqWeKRBH-gN9J7ZkJRgeCL3gBe0wAF0sXsST0qqNwXE1qxfY9FytrKRNQzPoLeAGmxrDza36FGfv5ph4DA-4pV-xonfJ0NzuOKR5s-OAU5-LNbKd_KbqtdmF3qB0eoyz1GtCjs6ipQ7DNk_oOJ41r4b7zwyW4Cl4dDbvrncxEGvyZEDnY-56Z8Bwx8MUpfjiEnQMiZYQJFU16C02bb6lvcVI4-KnKlkXJazHr9GlJeyRP0ROnOMP3a2xrA?type=png)](https://mermaid.live/edit#pako:eNqFUk1PwzAM_SuRT8C2PxBxA8FpSKiIA8rFa7w2WmNPaYKExv476ce6bgLhixO_p_fsOAcoxRJoKBts20eHVUBvWOV4Slw6YQxO1P33aqWeKRBH-gN9J7ZkJRgeCL3gBe0wAF0sXsST0qqNwXE1qxfY9FytrKRNQzPoLeAGmxrDza36FGfv5ph4DA-4pV-xonfJ0NzuOKR5s-OAU5-LNbKd_KbqtdmF3qB0eoyz1GtCjs6ipQ7DNk_oOJ41r4b7zwyW4Cl4dDbvrncxEGvyZEDnY-56Z8Bwx8MUpfjiEnQMiZYQJFU16C02bb6lvcVI4-KnKlkXJazHr9GlJeyRP0ROnOMP3a2xrA)
